using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace p_aladdin
{
    [Route("products")]
    [ApiController]
    public class _c_products : Controller
    {
        _c_db s_dal_ = new _c_db();

        [HttpGet]
        [Route("test")]
        public string f_test_() 
        {
            return "Test: " + DateTime.Now.ToString();
        }

        [HttpPost]
        [Route("list")]
        public List<_c_product> f_text_()
        {
            List<_c_product> l_lst_ = new List<_c_product>();

            s_dal_.f_open_();
            l_lst_ = (from i_usr_ in s_dal_.t_users
                      select i_usr_).Skip(p_pag_.s_skp_).Take(p_pag_.s_tak_).ToArray().ToList();
            s_dal_.f_close_(true);

            return l_lst_;
        }
    }
}