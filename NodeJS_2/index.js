// const CLI = require("./cli");
//CLI();
const controller = require("./controllers");
const http = require("http");
const server = http.createServer();

server.on("request", (req, res) => {
  switch (req.url) {
    case "/":
      controller.home(req, res);
      break;
    case "/contacts":
      if (req.method == "GET") controller.getAll(req, res);
      if (req.method == "POST") controller.addNew(req, res);
      break;
    case "/style.css":
      res.end("body{color:#3f51b5}");
      break;
    default:
      controller.notFound(req, res);
  }
});

server.listen(3000, () => console.log("server is on"));
