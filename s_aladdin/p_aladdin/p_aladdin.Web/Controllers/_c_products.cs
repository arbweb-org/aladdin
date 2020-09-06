using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

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
        public List<_c_product> f_list_()
        {
            List<_c_product> l_lst_ = new List<_c_product>();
            //l_lst_.Add(new _c_product() { s_nam_ = "p1", s_prc_ = 1.1 });
            //l_lst_.Add(new _c_product() { s_nam_ = "p2", s_prc_ = 2.2 });
            //l_lst_.Add(new _c_product() { s_nam_ = "p3", s_prc_ = 3.3 });

            return l_lst_;
        }

        [HttpPost]
        [Route("add")]
        public string  f_add_(_c_product p_pro_)
        {
            s_dal_.f_open_();
            s_dal_.t_Products.Add(p_pro_);

            if (s_dal_.f_save_())
            { s_dal_.f_close_(true); }
            else
            { s_dal_.f_close_(false); }

            return s_dal_.s_msg_;
        }
    }
}