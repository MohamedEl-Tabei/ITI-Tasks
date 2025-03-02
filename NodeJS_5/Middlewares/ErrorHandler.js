const ErrorHandler = (errApp, req, res, nxt) => {
  res.status(errApp.statusCode).json({ message: errApp.message });
};

module.exports = ErrorHandler;
