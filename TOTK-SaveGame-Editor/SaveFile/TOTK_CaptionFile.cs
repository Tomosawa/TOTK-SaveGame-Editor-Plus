using System.Drawing;
using System.IO;

namespace TOTK_SaveGame_Editor.SaveFile
{
    public class TOTK_CaptionFile : SaveFile
    {

        public TOTK_CaptionFile(string path)
        {
            if (!File.Exists(path)) return;

            _Path = path;
            _Data = File.ReadAllBytes(_Path);

        }

        public Image readImage()
        {
            for (var i = 0x000028; i < 0x000001c0; i += 8)
            {
                var hash = ReadUInt32(i);
                if (hash == 0x63696a32)
                { //found JPG hash
                    var jpgOffset = ReadUInt32(i + 4);
                    var jpgSize = ReadUInt32((int)jpgOffset);

                    var arrayBuffer = ReadArray((int)(jpgOffset + 4), (int)(jpgOffset + 4 + jpgSize));
                 
                    MemoryStream ms = new MemoryStream(arrayBuffer);
                    var img = Image.FromStream(ms);
                    return img;
                }
            }
            return null;
        }
    }
}
