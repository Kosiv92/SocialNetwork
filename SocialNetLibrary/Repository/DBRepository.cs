using Microsoft.EntityFrameworkCore;
using SocialNetLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetLibrary.Repository
{
    internal class DBRepository : IRepository
    {
        ApplicationContext _applicationContext;
        
        public DBRepository()
        {
            _applicationContext = new ApplicationContext();
        }
        
        public ApplicationContext ApplicationContext { get; set; }

        public void GetData()
        {
            throw new NotImplementedException();
        }

        public void SaveData()
        {
            throw new NotImplementedException();
        }
    }
}
