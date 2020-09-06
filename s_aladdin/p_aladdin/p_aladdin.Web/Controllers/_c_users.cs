using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace p_aladdin
{
    [Route("users")]
    [ApiController]
    public partial class _c_users : Controller
    {
        _c_db s_dal_ = new _c_db();

        [HttpPost]
        [Route("list")]
        public List<_c_user> f_text_(_c_page p_pag_)
        {
            List<_c_user> l_lst_ = new List<_c_user>();

            s_dal_.f_open_();
            l_lst_ = (from i_usr_ in s_dal_.t_users
                      //orderby i_usr_.s_dat_ descending
                      select i_usr_).Skip(p_pag_.s_skp_).Take(p_pag_.s_tak_).ToArray().ToList();
            s_dal_.f_close_(true);

            return l_lst_;
        }

        [HttpPost]
        [Route("add")]
        public string f_add_(_c_user p_usr_)
        {
            _c_user l_usr_ = new _c_user
            {
                s_nam_ = p_usr_.s_nam_,
                s_pas_ = p_usr_.s_pas_
            };

            s_dal_.f_open_();
            s_dal_.t_users.Add(l_usr_);

            if (s_dal_.f_save_())
            { s_dal_.f_close_(true); }
            else
            { s_dal_.f_close_(false); }

            return s_dal_.s_msg_;
        }
    }
}