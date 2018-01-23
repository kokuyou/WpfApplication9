using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Kinect;
using LightBuzz.Vitruvius;

namespace WpfApplication2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        KinectSensor _sensor;
        MultiSourceFrameReader _reader;
        PlayersController _playersController;

        JointType _start1 = JointType.ShoulderRight;
        JointType _center1 = JointType.ElbowRight;
        JointType _end1 = JointType.WristRight;

        JointType _start2 = JointType.ElbowLeft;
        JointType _center2 = JointType.ShoulderLeft;
        JointType _end2 = JointType.SpineShoulder;

        JointType _start3 = JointType.AnkleRight;
        JointType _center3 = JointType.KneeRight;
        JointType _end3 = JointType.HipRight;

        JointType _start4 = JointType.ShoulderLeft;
        JointType _center4 = JointType.ElbowLeft;
        JointType _end4 = JointType.WristLeft;

        JointType _start5 = JointType.ElbowRight;
        JointType _center5 = JointType.ShoulderRight;
        JointType _end5 = JointType.SpineShoulder;

        JointType _start6 = JointType.AnkleLeft;
        JointType _center6 = JointType.KneeLeft;
        JointType _end6 = JointType.HipLeft;

        
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
