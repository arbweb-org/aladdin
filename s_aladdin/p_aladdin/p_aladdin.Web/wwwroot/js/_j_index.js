v_loaded_();

function v_loaded_()
{
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