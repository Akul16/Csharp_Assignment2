function hideDisplaySection(section)
{
    var target = document.getElementById(section);

    if(target.style.display == "block")
    {
        target.style.display = "none";
    }
    else
    {
        target.style.display = "block";
    }
}