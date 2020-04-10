function click() {
	var body = document.querySelector("body")
	body.style.display = "none"
	setTimeout(function(){
		alert("Mda...")
	}, 300)
}
window.onload = function() {
	var btn = document.getElementById("button")
	btn.addEventListener("click", click)
}
