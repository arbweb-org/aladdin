using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace p_aladdin
{
    [Route("orders")]
    [ApiController]
    public class _c_orders : Controller
    {
        [HttpPost]
        [Route("list")]
        public List<_c_product> f_text_()
        {
            List<_c_product> l_lst_ = new List<_c_product>();



            return l_lst_;
        }
    }
}