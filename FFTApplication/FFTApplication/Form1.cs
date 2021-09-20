using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// Main Layout Structure
using System.Windows.Forms;
// Easy Way to generate Sine-Waves
using MathNet.Numerics;
// Complex Numbers
using System.Numerics;
// Easy Way to apply Fourier Transform
using MathNet.Numerics.IntegralTransforms;
// Used For Charts
using System.Windows.Forms.DataVisualization.Charting;
// For Generating Sound
using NAudio;
using NAudio.Wave.SampleProviders;
using NAudio.Wave;
using System.IO;

namespace FFTApplication
{
    public partial class MainWindow : Form
    {
        // Sample Configuration Constants
        static double durationTrack;
        static double portionTrack;
        static int sampleRate;
        static int num_samples;
        static int maxFreq;

        // List of all Wave Components and the current selected one
        static List<double[]> waveComponents = new List<double[]>() { new double[] { 0, 1, 0} }; // {Frequency, Magnitude, Phase}
        static int selectedWave = 0;

        // Initiate Random object, Static Tracker, and Random Data
        static double[] staticComponent;
        Random random = new Random();
        static int staticTrack = 0;

        // Set Graph Limits
        static double[] TimeDomainLims = new double[2];
        double absoluteMag;
        double absoluteFFTMag;

        double[] wave_data_double;
        Complex[] wave_data_complex;
        Complex[] fft_data;

        public MainWindow()
        {
            InitializeComponent();
            InitializeConstants(); // Set Up all the nessasary Values
            UpdateConstants(); // Resizes arrays and values to fit a new 'num_samples'
            InitializeGraphs(); // Does exactly what you'd think
            UpdateGraphs(); // Fills out each graph
            UpdateLims(); // Resizes each graph
        }

        private void InitializeConstants()
        {
            maxFreq = 1000; // Haven't tested for different maximum frequencies.
            portionTrack = 0.1;

            sampleRate = 10000; // Haven't tested for other Samplerates
            durationTrack = 0.5;
            num_samples = (int) (sampleRate * durationTrack);

            staticComponent = new double[num_samples];

            double[] wave_data_double = new double[num_samples];
            Complex[] wave_data_complex = new Complex[num_samples];
            Complex[] fft_data = new Complex[num_samples];
        }

        private void UpdateConstants()
        {
            // Sample Configuration Constants
            durationTrack = (double) DurationBar.Value / 50;
            
            num_samples = (int)(sampleRate * durationTrack);

            staticComponent = new double[num_samples];

            wave_data_double = new double[num_samples];
            wave_data_complex = new Complex[num_samples];
            fft_data = new Complex[num_samples];
        }

        public void InitializeGraphs()
        {
            // Initialize Wave Graph
            TimeDomain.Series["Wave"].IsVisibleInLegend = false;
            TimeDomain.Series["Wave"].ChartType = SeriesChartType.Line;

            TimeDomain.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 12.0f);
            TimeDomain.ChartAreas["ChartArea1"].AxisX.Title = "Seconds";
            TimeDomain.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            TimeDomain.ChartAreas["ChartArea1"].AxisX.MajorGrid.Interval = durationTrack * portionTrack * 0.2;
            TimeDomain.ChartAreas["ChartArea1"].AxisX.MajorTickMark.Interval = durationTrack * portionTrack * 0.2;

            // Initialize FFT Plot
            FreqDomain.Series["Freq"].IsVisibleInLegend = false;
            FreqDomain.Series["Freq"].ChartType = SeriesChartType.Line;

            FreqDomain.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 12.0f);
            FreqDomain.ChartAreas["ChartArea1"].AxisX.Title = "Hz";
            FreqDomain.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            FreqDomain.ChartAreas["ChartArea1"].AxisX.Maximum = maxFreq;
            FreqDomain.ChartAreas["ChartArea1"].AxisX.MinorTickMark.Enabled = true;

            // Dummy data that only serves to ajust the range of data ploted, NOT displayed
            TimeDomain.Series.Add("nl");
            TimeDomain.Series["nl"].Color = Color.Transparent;
            TimeDomain.Series["nl"].IsValueShownAsLabel = false;
            TimeDomain.Series["nl"].IsVisibleInLegend = false;
            TimeDomain.Series["nl"].ChartType = SeriesChartType.Point;

            // Dummy Data for the FFT plot
            FreqDomain.Series.Add("nl");
            FreqDomain.Series["nl"].Color = Color.Transparent;
            FreqDomain.Series["nl"].IsValueShownAsLabel = false;
            FreqDomain.Series["nl"].IsVisibleInLegend = false;
            FreqDomain.Series["nl"].ChartType = SeriesChartType.Point;

            UpdateLims();
        }

        private void UpdateGraphs()
        {
            UpdateGraphWaveData();
            PlotWaveform();
            PlotFFT();
        }
        
        private void UpdateGraphWaveData()
        {
            double[] graph_wave_data = GenerateWaveData(num_samples);
            for (int i = 0; i < graph_wave_data.Length; i++)
            {
                wave_data_complex[i] = new Complex(graph_wave_data[i], 0);
                wave_data_double[i] = graph_wave_data[i];
            }
        }

        public double[] GenerateWaveData(int amt_samples)
        {
            double[] final_array = new double[amt_samples];

            

            // An empty list to fill with arreys of type Double
            List<double[]> sinusoids = new List<double[]>();

            // Fill the new list with arreys of doubles
            for (int i = 0; i < waveComponents.Count; i++)
            {
                sinusoids.Add(Generate.Sinusoidal(amt_samples, sampleRate, waveComponents[i][0], waveComponents[i][1], 0, waveComponents[i][2]));
            }

            // Convert Type Double to Type Complex to allow compatiability for the Fourier Transform
            double finalValue;
            for (int i = 0; i < amt_samples; i++)
            {
                finalValue = 0;
                for (int j = 0; j < waveComponents.Count; j++)
                {
                    finalValue += sinusoids[j][i];
                }
                finalValue += staticComponent[i];  // Assumes "i" doesnt go out of range
                final_array[i] = finalValue;
            }
            return final_array;
        }

        private void PlotWaveform()
        {
            // Initialize Data
            TimeDomain.Series["Wave"].Points.Clear();

            // Simply plot only the real components of the wave data
            for (int i = 0; i < num_samples * portionTrack; i++)
            {
                double time = ((double) i / sampleRate);

                TimeDomain.Series["Wave"].Points.AddXY
                    (time, wave_data_complex[i].Real);
            }
        }

        private void PlotFFT()
        {
            FreqDomain.Series["Freq"].Points.Clear();

            fft_data = wave_data_complex;
            
            // Apply the FFT, Convert from time domain to frequency domain  (Time => Freqs)
            Fourier.Forward(fft_data, FourierOptions.NoScaling);

            // Plot the frequency spectrum, but only up to the highest possible frequency we can produce
            for (int i = 0; i <= maxFreq * durationTrack; i++)
            {
                // Get the magnitude of each FFT smaple
                // = abs[sqrt(r^2 + i ^2)]
                double mag = ((double) 2.0 / num_samples) * (Math.Abs(Math.Sqrt(Math.Pow(fft_data[i].Real, 2) + 
                    Math.Pow(fft_data[i].Imaginary, 2))));

                // Determine the Hz represented by each sample
                double Hz = i * ((double) sampleRate / num_samples);

                FreqDomain.Series["Freq"].Points.AddXY
                    (Hz, mag);
            }
        }

        private void MakeGraphNoise(double mag)
        {
            for(int i = 0; i < num_samples; i++)
            {
                staticComponent[i] = 0;
                double staticValue = (((double)random.Next(0, 2000) * mag) / 1000) - mag;
                staticComponent[i] += staticValue;
            }
        }

        private void UpdateUI()
        {
            FreqLblSlt.Text = "Frequency " + (selectedWave + 1).ToString();
            FreqBar.Value = (int) waveComponents[selectedWave][0] / 2;
            FreqLbl.Text = waveComponents[selectedWave][0].ToString() + " Hz";
            MagBar.Value = (int) waveComponents[selectedWave][1] * 20;
            MagLbl.Text = waveComponents[selectedWave][1].RoundToMultiple(0.1).ToString() + " Mag";
            PhaseBar.Value = (int) waveComponents[selectedWave][2] * 10;
            PhaseLbl.Text = waveComponents[selectedWave][2].RoundToMultiple(0.1).ToString() + " Phase";
        }

        private void UpdateLims()
        {
            TimeDomainLims[0] = 0f;
            TimeDomainLims[1] = durationTrack * portionTrack;

            absoluteMag = wave_data_double.Max().RoundToMultiple(0.1);
            absoluteFFTMag = waveComponents[0][1];
            for (int i = 1; i < waveComponents.Count; i++)
            {
                if (waveComponents[i][1] > absoluteFFTMag)
                {
                    absoluteFFTMag = waveComponents[i][1];
                }
            }
        

            // Set or Reset Wave Form Limit values (Max/Mins for x/y)
            TimeDomain.Series["nl"].Points.Clear();
            TimeDomain.Series["nl"].Points.AddXY(
                TimeDomainLims[0], absoluteMag * -1.25);
            TimeDomain.Series["nl"].Points.AddXY(
                TimeDomainLims[1], absoluteMag * 1.25);

            // Set or Reset the FFT limit Values
            FreqDomain.Series["nl"].Points.Clear();
            FreqDomain.Series["nl"].Points.AddXY(2, absoluteFFTMag);
            FreqDomain.Series["nl"].Points.AddXY(maxFreq, absoluteFFTMag);

            // Update Tick Distance after zoom
            TimeDomain.ChartAreas["ChartArea1"].AxisX.MajorGrid.Interval = (durationTrack * portionTrack * 0.2).RoundToMultiple(0.1);
            TimeDomain.ChartAreas["ChartArea1"].AxisX.MajorTickMark.Interval = (durationTrack * portionTrack * 0.2).RoundToMultiple(0.1);
        }

        private double[] ScaleData(double[] sound_data)
        {
            double[] scaled_data = new double[sound_data.Length];
            // Scales data to fit into a range from -1 to 1.
            double max_value = sound_data.Max();
            if (max_value >= 1)
            {
                for (int i = 0; i < sound_data.Length; i++)
                {
                    scaled_data[i] = sound_data[i] / max_value;
                }
                return scaled_data;
            }
            else
            {
                return sound_data;
            }
        }

        private void playSounds()
        {
            int num_sound_samples = num_samples;  // Variable Change isnt needed, but offers flexibility for possible changes

            double[] sound_data = GenerateWaveData(num_sound_samples);
            double[] scaled_data = ScaleData(sound_data);

            var raw = new byte[num_sound_samples * 2];

            //*
            for (int n = 0; n < num_sound_samples; n++)
            {
                var sample = (short)(scaled_data[n] * Int16.MaxValue);
                var bytes = BitConverter.GetBytes(sample);
                raw[n * 2] = bytes[0];
                raw[n * 2 + 1] = bytes[1];
            }
            //*/


            var ms = new MemoryStream(raw);
            var rs = new RawSourceWaveStream(ms, new WaveFormat(sampleRate, 16, 1));

            var wo = new WaveOutEvent();
            wo.Init(rs);
            wo.Play();
            while (wo.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(500);
            }
            wo.Dispose();
        }

        ///////////////////////////////////////////////////////////////////////
        // Slider Event Handlers
        private void FreqBar_Scroll(object sender, EventArgs e)
        {
            waveComponents[selectedWave][0] = FreqBar.Value * 2;
            FreqLbl.Text = waveComponents[selectedWave][0].ToString() + " Hz";
            UpdateLims();
            UpdateGraphs();
        }
        private void MagBar_Scroll(object sender, EventArgs e)
        {
            waveComponents[selectedWave][1] = MagBar.Value * 0.05f;
            MagLbl.Text = waveComponents[selectedWave][1].RoundToMultiple(0.01).ToString() + " Mag";
            UpdateLims();
            UpdateGraphs();
        }
        private void PhaseBar_Scroll(object sender, EventArgs e)
        {
            waveComponents[selectedWave][2] = PhaseBar.Value * 0.1f;
            PhaseLbl.Text = waveComponents[selectedWave][2].RoundToMultiple(0.1).ToString() + " Phase";
            UpdateGraphs();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            staticTrack = StaticBar.Value;
            StaticLbl.Text = (staticTrack * 10).ToString() + "% Static";
        }

        private void PortionBar_Scroll(object sender, EventArgs e)
        {
            portionTrack = (double)PortionBar.Value / 100;
            UpdateGraphs();
            UpdateLims();
            PortionQuantLbl.Text = portionTrack.ToString();
        }

        private void DurationBar_Scroll(object sender, EventArgs e)
        {
            UpdateConstants();
            UpdateGraphs();
            UpdateLims();
            DurationQuantLbl.Text = durationTrack.ToString();
        }

        // Buttun Event Handlers
        ////////////////////////////////////////////////////////////////////////
        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (selectedWave == waveComponents.Count - 1)
            {
                waveComponents.Add(new double[] { 0, 0, 0 });
            }
            selectedWave++;
            FreqLblSlt.Text = "Frequency " + (selectedWave + 1).ToString();
            UpdateUI();
        }
        private void FreqSltBtnDel_Click(object sender, EventArgs e)
        {
            if(waveComponents.Count > 1)
            {
                waveComponents.RemoveAt(selectedWave);
                selectedWave = 0;

                UpdateLims();
                UpdateUI();
                UpdateGraphs();
            }            
        }

        private void PrvBtn_Click(object sender, EventArgs e)
        {
            if (selectedWave > 0)
            {
                selectedWave--;
                FreqLblSlt.Text = "Frequency " + (selectedWave + 1).ToString();
            }
            UpdateUI();
        }

        private void FreqBtnUp_Click(object sender, EventArgs e)
        {
            waveComponents[selectedWave][0] = waveComponents[selectedWave][0] + 2;
            FreqLbl.Text = waveComponents[selectedWave][0].ToString() + " Hz";
            UpdateGraphs();
        }

        private void FreqBtnDown_Click(object sender, EventArgs e)
        {
            waveComponents[selectedWave][0] = waveComponents[selectedWave][0] - 2;
            FreqLbl.Text = waveComponents[selectedWave][0].ToString() + " Hz";
            UpdateGraphs();
        }

        private void MagBtnUp_Click(object sender, EventArgs e)
        {
            waveComponents[selectedWave][1] = waveComponents[selectedWave][1] + 0.1;
            MagLbl.Text = waveComponents[selectedWave][1].RoundToMultiple(0.1).ToString() + " Mag";
            UpdateGraphs();
            UpdateLims();
        }

        private void MagBtnDown_Click(object sender, EventArgs e)
        {
            waveComponents[selectedWave][1] = waveComponents[selectedWave][1] - 0.1;
            MagLbl.Text = waveComponents[selectedWave][1].RoundToMultiple(0.1).ToString() + " Mag";
            UpdateGraphs();
            UpdateLims();
        }

        private void PhaseBtnUp_Click(object sender, EventArgs e)
        {
            waveComponents[selectedWave][2] = waveComponents[selectedWave][2] + 0.1;
            PhaseLbl.Text = waveComponents[selectedWave][2].RoundToMultiple(0.1).ToString() + " Phase";
            UpdateGraphs();
        }

        private void PhaseBtnDown_Click(object sender, EventArgs e)
        {
            waveComponents[selectedWave][2] = waveComponents[selectedWave][2] - 0.1;
            PhaseLbl.Text = waveComponents[selectedWave][2].RoundToMultiple(0.1).ToString() + " Phase";
            UpdateGraphs();
        }

        private void StaticBtnDown_Click(object sender, EventArgs e)
        {
            staticTrack--;
            StaticLbl.Text = (staticTrack * 10).ToString() + "% Static";
        }

        private void StaticBtnApply_Click(object sender, EventArgs e)
        {
            MakeGraphNoise(((double)staticTrack * absoluteMag) / 10);
            UpdateGraphs();
        }

        private void StaticBtnUp_Click(object sender, EventArgs e)
        {
            staticTrack++;
            StaticLbl.Text = (staticTrack * 10).ToString() + "% Static";
        }

        private void PlaySoundBtn_Click(object sender, EventArgs e)
        {
            playSounds();
        }
    }
}
