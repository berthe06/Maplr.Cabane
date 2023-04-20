using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.SharedKernel
{
    public class EnumUtils
    {
        public enum TypeSucre
        {
            AMBER,
            DARK,
            CLEAR
        }
        

        public enum MsgCode
        {

            HTTP_CODE_200,
            HTTP_CODE_201,
            HTTP_CODE_202,
            HTTP_CODE_204,

            HTTP_CODE_302,
            HTTP_CODE_304,
            HTTP_CODE_307,
            HTTP_CODE_308,

            HTTP_CODE_400,
            HTTP_CODE_401,
            HTTP_CODE_403,
            HTTP_CODE_404,
            HTTP_CODE_408,

            HTTP_CODE_500,
            HTTP_CODE_511,
            HTTP_CODE_599,
            DUPLICATE_USERNAME,
            LOGIN_FAILED,
            USER_NOT_ACTIVE,
            INVALID_USER_PASSWORD,
            INVALID_USERNAME_OR_PASSWORD,
        }

    

    }

}
