const cards = document.getElementsByClassName("card");
let id = 1;
for (const card of cards) {
    card.id = "card" + id;
    card.draggable = true;
    card.ondragstart = drag;
    id++;
}

const tds = document.getElementsByTagName("td");
for (const td of tds) {
    td.ondrop = drop;
    td.ondragover = allowDrop;
}


function allowDrop(ev) {
    ev.preventDefault();
}

function drag(ev) {
    ev.dataTransfer.setData("text", ev.target.id);
}

function drop(ev) {
    ev.preventDefault();
    if (ev.target.childElementCount != 0) return;
    if (ev.target.tagName != "TD") return;
    var data = ev.dataTransfer.getData("text");
    ev.target.appendChild(document.getElementById(data));
}
function tableDrop(ev) {
    ev.preventDefault();
    if (ev.target.tagName != "DIV") return;
    var data = ev.dataTransfer.getData("text");
    ev.target.appendChild(document.getElementById(data));
}