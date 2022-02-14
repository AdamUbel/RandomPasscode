let count = 1;
function generate(length) {
  var result = "";
  var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
  var charactersLength = characters.length;
  for (var i = 0; i < length; i++) {
    result += characters.charAt(Math.floor(Math.random() * charactersLength));
  }

  document.getElementById("passcode").innerHTML = result;
  document.getElementById("count").innerHTML = `(passcode # ${count++})`;
}

generate(14);
