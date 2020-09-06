using System;

namespace p_aladdin
{
    public class _c_page
    {
        public int s_skp_ { get; set; }
        public int s_tak_ { get; set; }

        public static int f_pages_count_(int p_ttl_, int p_tak_ = 10)
        {
            var l_dbl_ = (double)p_ttl_ / (double)p_tak_;
            var l_int_ = (int)Math.Ceiling(l_dbl_);
            return Math.Max(1, l_int_);
        }

        /// <summary>
        /// returns first _f_page
        /// </summary>
        /// <param name="p_tak_"></param>
        /// <returns></returns>
        public static _c_page f_first_(int p_tak_ = 10)
        {
            return f_index_(1);
        }

        /// <summary>
        /// returns last _c_page
        /// </summary>
        /// <param name="p_ttl_"></param>
        /// <param name="p_tak_"></param>
        /// <returns></returns>
        public static _c_page f_last_(int p_ttl_, int p_tak_ = 10)
        {
            return new _c_page
            {
                s_skp_ = Math.Max(p_ttl_ - 10, 0),
                s_tak_ = p_tak_
            };
        }

        /// <summary>
        /// returns _c_page at 1 based index with a given number of records
        /// </summary>
        /// <param name="p_ndx_">1 based index</param>
        /// <param name="p_tak_">the number of records in page</param>
        /// <returns></returns>
        public static _c_page f_index_(int p_ndx_, int p_tak_ = 10)
        {
            return new _c_page
            {
                s_skp_ = (p_ndx_ - 1) * p_tak_,
                s_tak_ = p_tak_
            };
        }
    }
}