
function validatePatient() {
    var firstName =
        document.getElementsByName("FirstName")[0].value;

    var email =
        document.getElementsByName("Email")[0].value;

    if (firstName == "") {
        alert("First Name Required");
        return false;
    }

    if (email == "") {
        alert("Email Required");
        return false;
    }

    return true;
}