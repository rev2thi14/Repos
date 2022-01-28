using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialApplicationEntity
{
    class UserInfoModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Email { get; set; }
        public int Mobile{ get; set; }
        public int Password { get; set; }
    }
}
