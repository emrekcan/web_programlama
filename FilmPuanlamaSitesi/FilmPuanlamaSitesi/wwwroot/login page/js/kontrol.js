function form()
{
    var email = document.getElementById('Email');
    var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;

    if (!filter.test(email.value))
    {
        alert("Geçersiz email adresi")
        email.focus;
        return false;
    }
}