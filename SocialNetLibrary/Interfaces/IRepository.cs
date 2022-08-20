using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetLibrary.Interfaces
{
    internal interface IRepository
    {
        public void GetData(); //разобраться что я возвращаю из БД

        public void SaveData();
    }
}
