using System;
using System.IO;

using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace AAStudio
{
    [Serializable()]
    public class ArtFile
    {
        #region "Private members"
        [NonSerialized()]
        private string _name = "<No Name>";
        [NonSerialized()]
        private string _filepath = null;
        private List<ArtSprite> _sprites = null;
        #endregion

        #region "Constructors"
        public ArtFile()
        {
            _sprites = new List<ArtSprite>();
            _sprites.Add(new ArtSprite("no_name", 128, 64));
        }
        #endregion

        #region "Methods"
        public static ArtFile Load(string filepath)
        {
            ArtFile rc;

            rc = null;

            if (File.Exists(filepath) == true)
            {
                rc = Deserialize(filepath);
                rc._filepath = filepath;
                rc._name = Path.GetFileNameWithoutExtension(filepath);
            }

            return rc;
        }

        public void Save()
        {

            Serialize(_filepath);
        }

        public void SaveAs(string filepath)
        {
            if (File.Exists(filepath) == true)
                File.Delete(filepath);
            _filepath = filepath;
            _name = Path.GetFileNameWithoutExtension(filepath);
            Save();
        }

        private static ArtFile Deserialize(string filepath)
        {
            FileStream fs;
            BinaryFormatter bf;
            ArtFile rc;

            if (File.Exists(filepath) == true)
            {
                fs = new FileStream(filepath, FileMode.Open);
                bf = new BinaryFormatter();
                rc = (ArtFile)bf.Deserialize(fs);
                fs.Close();
                return rc;
            }
            else
                throw new FileNotFoundException();
        }

        private void Serialize(string filename)
        {
            BinaryFormatter bf;
            FileStream fs;

            if (File.Exists(filename) == true)
                File.Delete(filename);

            bf = new BinaryFormatter();
            fs = new FileStream(filename, FileMode.CreateNew);
            bf.Serialize(fs, this);
            fs.Close();
        }

        public MemoryStream Serialize()
        {
            BinaryFormatter bf;
            MemoryStream ms;

            bf = new BinaryFormatter();
            ms = new MemoryStream();
            bf.Serialize(ms, this);
            return ms;
        }

        public string Export()
        {
            StringBuilder sb;

            sb = new StringBuilder();

            foreach (ArtSprite sprite in _sprites)
                sb.AppendLine(sprite.Export());

            return sb.ToString();
        }

        #endregion

        #region "Properties"
        public string Name
        {
            get { return _name; }
        }

        public string FilePath
        {
            get { return _filepath; }
        }

        public List<ArtSprite> Sprites
        {
            get { return _sprites; }
        }
        #endregion
    }
}
