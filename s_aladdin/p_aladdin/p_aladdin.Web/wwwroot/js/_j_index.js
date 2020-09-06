v_loaded_();

function v_loaded_()
{
    $(document).foundation();
    v_resize_();
}

function v_resize_() { }

// Handle the response is succeeded
function v_success_(p_dat_, p_sts_, p_xhr_)
{
    alert(p_dat_);
}

// Handle the response on error
function v_error_(p_xhr_, p_sts_, p_msg_)
{
    alert(p_sts_);
    alert("Error: " + p_msg_);
}

function v_add_user_()
{
    // We are declaring a NEW JSON object
    var l_usr_ =
    {
        get s_nam_() { return document.getElementById('b_nam_').value; },   // Name
        get s_pas_() { return document.getElementById('b_pas_').value; }    // Password
    };

    v_post_obj_('users/add', l_usr_, v_success_, v_error_);
}

function v_add_product_()
{
    var l_prc_ = parseFloat(document.getElementById('b_prc_').value);

    // We are declaring a NEW JSON object
    var l_pro_ =
    {
        get s_nam_() { return document.getElementById('b_nam_').value; },   // Name product
        get s_prc_() { return l_prc_; }                                     // Pirce
    };

    alert(JSON.stringify(l_pro_));

    v_post_obj_('products/add', l_pro_, v_success_, v_error_);
}