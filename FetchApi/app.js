fetch("https://localhost:7129/api/Category/GetAllCategories")
	.then((response) => response.json())
	.then((data) => {
		let categories = document.querySelector("#category");
		for (let i = 0; i < data.length; i++) {
			let li = document.createElement("li");
			li.textContent = data[i].catName;
			categories.appendChild(li);
		}
	});

fetch("https://localhost:7129/api/Product/GetAllProducts")
	.then((response) => response.json())
	.then((data) => {
		let Product = document.querySelector("#product");
		for (let i = 0; i < data.length; i++) {
			let li = document.createElement("li");
			li.textContent = data[i].name;
			Product.appendChild(li);
		}
	});
