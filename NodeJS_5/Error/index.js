class AppError extends Error {
  statusCode;
  constructor(message, statusCode) {
    console.log(message);

    super(message);
    this.statusCode = statusCode;
  }
}

module.exports = AppError;
