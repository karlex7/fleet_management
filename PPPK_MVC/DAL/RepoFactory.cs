using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPPK_MVC.DAL
{
    public static class RepoFactory
    {
        public static IRepo GetRepo()
        {
            return new DBRepo();
        }
    }
}