using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PicExplorer
{
    public class tCoord
    {
        public int x,y,x1,y1;                               //Image Coordinates (image)
        public int xOffset, yOffset;                        //Offset, for multi-sprites
        public int xZoom, yZoom;                            //Zoom
        public int Angle, Flip;                             //Angle, Flip
        public int OutlineColorARGB,BackgroundColorARGB;    //Color of Background and Outline

        public tCoord()
        {
            x = y = x1 = y1 = 0;
            OutlineColorARGB =  BackgroundColorARGB = 0;
            xOffset = yOffset = 0;
            Angle = Flip = 0;
            xZoom = yZoom = 0;
        }
        public void Set(int value)
        {
            x = y = x1 = y1 = value;
        }

        /// <summary>
        /// Gets outline color, and, starting and ending position of data in grid. Starts/End at data, not grid.
        /// Optionally changes OutlineColor and BackGroundColor
        /// </summary>
        /// <param name="bm">Bitmap to search</param>
        /// <param name="OutlineColor">Optional: New OutlineColor. 0=auto</param>
        /// <param name="BackgroundColor">Optional: New Background color</param>
        /// <returns>false=fail, true=ok</returns>
        public bool GetGridBoundary(Bitmap bm, int? OutlineColor = null, int? BackgroundColor = null)
        {
            int tmpColor = 0;
            Set(0); //clear

            if (OutlineColor != null) OutlineColorARGB = OutlineColor.Value;
            BackgroundColor = BackgroundColor ?? 0;            
            
            //find first outline
            do
            {
                if (OutlineColorARGB == 0) //undefined
                {
                    OutlineColorARGB = bm.GetPixel(x, y).ToArgb(); if (OutlineColorARGB != BackgroundColorARGB) break;
                } else
                {
                    tmpColor = bm.GetPixel(x, y).ToArgb(); if (tmpColor == OutlineColorARGB) break;
                }
                if (++x == (bm.Width - 1))
                {
                    x = 0;
                    if (++y == bm.Height) return (false); //fail
                }
            } while (true);

            //find where outline ends, y first...            
            for (y1 = y; y1 < bm.Height; y1++)
            {
                if (bm.GetPixel(x, y1).ToArgb() != OutlineColorARGB) break;
            }

            //find where outline ends, x...            
            for (x1 = x; x1 < (bm.Width - 1); x1++)
            {
                if (bm.GetPixel(x1, y).ToArgb() != OutlineColorARGB) break;
            }

            if ((x == x1) || (y == y1)) return false;           //FAIL if there's nothing
            x++; y++;     //adjust first outline, one pixel below, right
            x1--; y1--;   //adjust last outline, one pixel above,left

            return (true); //coordinates of data, 
        }
    }

    //----------------------------------------------------------------------

    //A sprite references 1 or more images
    public class Sprite {
        public int SpriteNumber = 0;        
        public List<tCoord> Coords;			//coordinate list, supports sprite overlaying
    }

    //Sequence of sprites
    public class Animation {
        public static int SequenceMax = 0;	//global sequence counter

        public string Name;					//Animation Name
        public int MainImage;				//Animatin sequence #
        public List<Sprite> Frames;         //Sprites
		//Create default empty Animation frame
		public Animation()
        {
			MainImage = ++SequenceMax;
            Name = "Untitled" + MainImage.ToString();
            Frames.Add(new Sprite());   
        }
    }

    public class MainImage {
        public Image SourceImage;          //Source bitmap, with all sprites        
		public string SourceImageFilename;	//Filename
        public List<Animation> Sequences;	//List of coordinates, each sprite
        public List<int> Timings;			//Timing between sprites
		
		//Create default blank project
		public MainImage() {
			SourceImage = null;
			SourceImageFilename = "";
			Sequences = new List<Animation>();
			Timings = new List<int>();
		}
    }

}
