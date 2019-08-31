using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///用户表
    ///</summary>
    public partial class user
    {
        public  user()
        {

        }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string ID { get; set; }

        /// <summary>
        /// Desc:邮箱
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public int? emil { get; set; }
    }
}