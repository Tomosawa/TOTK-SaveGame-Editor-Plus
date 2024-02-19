using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOTK_SaveGame_Editor.Data
{
    public class SwordsData
    {
        public string Id { get; set; }
        public string Name_EN { get; set; }
        public string Name_CN { get; set; }
        public string Name_JP { get; set; }
        public string Description_EN { get; set; }
        public string Description_CN { get; set; }
        public string Description_JP { get; set; }
        public int Damage { get; set; }
        public float Range { get; set; }
        public int AttackSpeed { get; set; }
        public int Durability { get; set; }
    }
}
