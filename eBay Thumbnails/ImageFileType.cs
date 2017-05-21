using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eBay_Thumbnails
{
    static class ImageFileType
    {
        private static string imageType;

        static ImageFileType()
        {
            imageType = "JPG";
        }


        public static string getImageFileType()
        {
            return imageType;
        }

        public static void setImageFileType(string type)
        {
            imageType = type;
        }

    }
}
