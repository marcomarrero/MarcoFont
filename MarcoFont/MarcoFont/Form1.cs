using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using PicExplorer;

namespace MarcoFont
{
	
	public partial class Form1 : Form    {

		public MainImage myImage;

		public Form1()  {	
			myImage = new MainImage();
			InitializeComponent();
        }

        private void bBackground_Click(object sender, EventArgs e)
        {
            //            
        }

        private void getmyzoom(int iForceZoom = 0) {            
            lZoom.Text = trackBar1.Value.ToString();
            if (myImage.SourceImage == null) return;
            //zoom...
            int iNewZoom = 100;
            if (iForceZoom != 0) iNewZoom = iForceZoom; else iNewZoom = trackBar1.Value;
            pbX.Image = mScaler.ScaleByPercent(myImage.SourceImage, iNewZoom, System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor);            
        }
		
        private Color getmypixel() {
            //mouse coord
            Point mymouse = new Point(); mymouse = pbX.PointToClient(Cursor.Position);                        

            //cast bitmap to access drawing commands
            Bitmap bm = (Bitmap)pbX.Image;

            try {
                return (bm.GetPixel(mymouse.X, mymouse.Y));            
            }
            catch {
                return Color.Black;
            }
            
        }

        private void bZoom_Click(object sender, EventArgs e)
        {
            getmyzoom();
        }

        private void pbX_MouseClick(object sender, MouseEventArgs e)
        {
            //select new color...   (PointToScreen = Global coord) 
            if (pbX.Image == null)
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            switch (e.Button)
            {
                case MouseButtons.Left:                    
                    bOutline.BackColor = getmypixel();
                    if (!bOutline.Visible) bOutline.Visible=true;
                        break;

                case MouseButtons.Right:
                    bBackground.BackColor = getmypixel();
                    break;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            getmyzoom();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //
        }

        private void bProcess_Click(object sender, EventArgs e)
        {
            //const int COLOR_TRANSPARENT = -16777216;
            //no pic
            if (myImage.SourceImage == null)
            {
                MessageBox.Show("No image!");
                return;
            }
            char bitOn = '#';
            char bitOff = '.';

            //allows me to use drawing stuff
            getmyzoom(100);
            Bitmap bmView = (Bitmap)pbX.Image;
            Bitmap bmSource = (Bitmap)myImage.SourceImage;
			
            //storage            
            var IntySource = new List<string>();
            StringBuilder IntyLine = new StringBuilder(4096);

            IntyLine.Clear();
            IntyLine.AppendLine("'---- Source: " + textBox1.Text);
            IntyLine.AppendLine("' " +  DateTime.Now.ToString("D"));
            IntyLine.AppendLine("' ");
            IntySource.Add(IntyLine.ToString());
            
            //Coordinates...
            tCoord m = new tCoord(); 
            tCoord mSource = new tCoord();
            

            tResult.Clear();

            //values            
            UInt32 bit32, bitvalue32;
            UInt16 bit16, bitvalue16;
            byte bit8, bitvalue8;
            
            uint bitcount, line;
            char bitset = ' ';
            int total = 0;

            //
            int xsize = 0; int ysize = 0;
            
            //Get grid boundary. Use GUI colors if user picked them
            int? outlineARGB = null;    if (bOutline.Visible) outlineARGB = bOutline.BackColor.ToArgb();         //outline/grid color
            int? backARGB = null;       if (bBackground.Visible) backARGB = bBackground.BackColor.ToArgb();   //back color            
            mSource.GetGridBoundary(bmSource,outlineARGB, backARGB);
            int colorARGB = 0;                                  //color picked 

            //x1=starting left position   //y1=starting top position
            m.x1 = mSource.x; m.y1 = mSource.y;

            do
            {
                m.y = m.y1;
                line = 0;
                IntyLine.Clear();                
                IntyLine.AppendLine("Sprite" + total.ToString() + ":");

                do //y       
                {
                    m.x = m.x1;             //reset X

                    //reset values
                    bit32 = 0x80000000; bitvalue32 = 0; 
                    bit16 = 0x8000; bitvalue16 = 0;
                    bit8 = 0x80; bitvalue8 = 0; 
                    
                    bitcount = 1;
                    xsize = 0;
                    IntyLine.Append("\tBITMAP \"");

                    do //x
                    {
                        
                        colorARGB = bmSource.GetPixel(m.x, m.y).ToArgb();

                        if (colorARGB == outlineARGB)
                        {
                            break;   //found grid/outline? exit!!
                        }
                        else if ((colorARGB == backARGB))       // || (colorARGB == COLOR_TRANSPARENT)
                        {
                            bitset = bitOff;        //background character                            
                        }
                        else
                        {
                            bitvalue32 += bit32;        //found bit                            
                            if (bitcount <= 16) bitvalue16 += bit16;
                            if (bitcount <= 8) bitvalue8 += bit8;

                            bitset = bitOn;         //character                                 
                        };

                        //add to result
                        IntyLine.Append(bitset);
                        bmSource.SetPixel(m.x, m.y, Color.FromArgb(colorARGB ^ 0x00FFFFFF));    //reverse video
                        
                        //next
                        xsize++;
                        m.x++; if (m.x >= mSource.x1) break;     //out of bounds? stop...

                        //bits...
                                               
                        bitcount++; if (bitcount > 32) break;    //too many bits? image out of bounds.. stop.
                        bit32 = (bit32 >> 1);
                        if (bitcount <= 16)
                        {
                            bit16 = (UInt16)(bit16 >> 1);
                        }
                        if (bitcount <= 8)
                        {
                            bit8 = (byte)(bit8 >> 1);
                        }



                    } while (true);

                    //Got entire X/line... end line
                    if (bitcount > 17)
                    {
                        IntyLine.AppendLine(string.Format("\"\t'${0:X8}", bitvalue32));
                    } else if (bitcount > 9)
                    {
                        IntyLine.AppendLine(string.Format("\"\t'${0:X4}", bitvalue16));
                    } else
                    {
                        IntyLine.AppendLine(string.Format("\"\t'${0:X2}", bitvalue8));
                    }

                    //y
                    m.y++; line++; ysize++;
                    if (m.y >= mSource.y1) break;        //y>bitmap                    
                    colorARGB = bmSource.GetPixel(m.x1, m.y).ToArgb();  //get pixel, continue if it's not border color
                } while (colorARGB != mSource.OutlineColorARGB);    //loop until Y bottom grid found

                //next character (right)...        //tResult.Text = tResult.Text + string.Format("'{0}',", sbits );
                IntySource.Add(String.Format("'===Sprite:{0} == Chr:{1}===== [{2},{3}]", total, (total + 256), xsize, ysize));
                IntySource.Add(IntyLine.ToString());
                
                total++;
                ysize = 0;
                m.x1 = m.x + 1;

                //if it's at rightmost...
                if (m.x1 > mSource.x1)
                {
                    m.x1 = mSource.x;   //restart X (go down, leftmost again)
                    m.y1 = ++m.y;       //go below grid.
                    if (m.y1 > mSource.y1) break;  //exit if out of grid/bounds
                }
            } while (true);

            //done reading all chars...
            string sTotalNow = string.Format("\r\n'//Total of {0} characters.", total);
            IntySource.Add(sTotalNow);

            tResult.Text = string.Join("\n",IntySource);
            getmyzoom();
            MessageBox.Show("Done.\n\n" + sTotalNow);
        }

        private void bOpen_Click_1(object sender, EventArgs e)
        {
            string sDirectory = String.Concat(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            //I'll avoid .JPG to set a good example, no one should save sprite/font files in .JPG format.
            openFileDialog1.Filter = "Image Files(*.bmp;*.png;*.gif)|*.bmp;*.png;*.gif|All files (*.*)|*.*";            
            openFileDialog1.InitialDirectory = mTools.registryRead("DefaultPath", sDirectory);
            openFileDialog1.Title = "Select a Graphics file";
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = false;
            bool Loaded = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBox1.Text = openFileDialog1.FileName;
                    pbX.Load(openFileDialog1.FileName);
                    myImage.SourceImage = (Image)pbX.Image.Clone();
                    Loaded = true;
                }
                catch (Exception xc)
                {
                    MessageBox.Show(xc.Message, @"Error opening/reading file.");
                }
                finally
                {
                    //recolor bitmap, zoom other
                    pbX.Image = mScaler.ScaleByPercent(myImage.SourceImage, 100, System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor);
                    getmyzoom();
                }
                //remember last path...                    
                if (!mTools.registryWrite("DefaultPath", System.IO.Path.GetFullPath(openFileDialog1.FileName)))
                {
                    MessageBox.Show("Cannot write settings to registry!");
                };
            }

            //Loaded? Then get boundary, get default colors.
            if (Loaded)
            {
                tCoord mSource = new tCoord();
                Bitmap bm = (Bitmap)pbX.Image;
                mSource.GetGridBoundary(bm, null, null);
                bOutline.BackColor = Color.FromArgb(mSource.OutlineColorARGB);
                //MISS! bBackground.BackColor = Color.FromArgb(mSource.BackgroundColorARGB);
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {

        }
    }
}

