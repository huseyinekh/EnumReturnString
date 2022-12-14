using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnumReturnString.Enums
{
    public enum ConnectionStrings
    {
        [Display(Name = "DataBase=SQL Server")]
        SqlServer_,
        [Display(Name = "DataBase=Mongo Db")]
        MongoDb_

    }
}
