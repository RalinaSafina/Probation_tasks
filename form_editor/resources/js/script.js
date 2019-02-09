/*jshint esversion: 6 */
let getById = function(id){
	return document.getElementById(id);
};

let createNewFormData = function(){
	let exampleBlock = getById("example");
	let fromDataBlock = exampleBlock.childNodes[1];
	let newBlock = fromDataBlock.cloneNode(true);
	newBlock.style.display = "block";
	let forms = getById("forms");
	forms.appendChild(newBlock);
};
//TODO изменить childNodes[3] на поиск по id
let changeSelectElement = function(event, value){
	let fromDataBlock = event.target.parentElement.parentElement;
	if(value === "text"){
		fromDataBlock.childNodes[3].style.display = "block";
		fromDataBlock.childNodes[5].style.display = "none";
	}else if(value === "textarea"){
		fromDataBlock.childNodes[5].style.display = "block";
		fromDataBlock.childNodes[3].style.display = "none";
	}else {
		fromDataBlock.childNodes[5].style.display = "none";
		fromDataBlock.childNodes[3].style.display = "none";
	}
};

let deleteFormData = function(event){
	let forms = getById("forms");
	forms.removeChild(event.target.parentElement);
};

let main = function(){
	createNewFormData();
};

document.addEventListener("DOMContentLoaded", main);