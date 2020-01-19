function openNav(vertical = false, navid = "hidablenav", navsize = "250px") {
    if (vertical == false) {
        document.getElementById(navid).style.width = navsize;
    }
    else {
        document.getElementById(navid).style.height = navsize;
    }
}

function closeNav(vertical = false, navid = "hidablenav") {
    if (vertical == false) {
        document.getElementById(navid).style.width = 0;
    }
    else {
        document.getElementById(navid).style.height = 0;
    }
}