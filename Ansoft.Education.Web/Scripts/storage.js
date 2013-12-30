
/*本地一直存储*/
function setlocalStorage() {
    localStorage.name = document.getElementById('localinput').value.toString();
}

function getlocalStorage() {
    if (localStorage.name == null) {
        document.getElementById('localinputcontent').innerHTML = "No Name";
    }
    document.getElementById('localinputcontent').innerHTML = localStorage.name;
}

/*会话存储*/
function setSessionStorage() {
    sessionStorage.name = document.getElementById('sessioninput').value.toString();
}

function getSessionStorage() {
    if (sessionStorage == null) {
        document.getElementById('sessioninputcontent').innerHTML = "No Name";
    }
    document.getElementById('sessioninputcontent').innerHTML = sessionStorage.name;
}
