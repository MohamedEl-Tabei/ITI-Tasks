using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using SocialMediaApi.BL;

namespace SocialMediaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _manager;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public UserController(IUserManager manager, IStringLocalizer<SharedResources> localizer)
        {
            _manager = manager;
            _localizer = localizer;
        }

        [HttpGet]
        public async Task<Ok<List<UserRead>>> GetAll() => TypedResults.Ok(await _manager.GetAllAsync());

        [HttpPost]
        public async Task<Results<Ok, BadRequest<GeneralResult<UserCreate>>>> Create(UserCreate user)
        {
            var x = _localizer[AppConstants.ErrorMessages.NameNotEmpty];
            var result = await _manager.CreateAsync(user);
            return result.Success ? TypedResults.Ok() : TypedResults.BadRequest(result);
        }
        [HttpPost("image")]
        public async Task<Results<Ok<FileUploadResult>, BadRequest<string>>> UploadFile(
        [FromForm] FileUploadRequest fileRequest
        )
        {
            var file = fileRequest.File;
            var exteenstion = Path.GetExtension(file.FileName).ToLowerInvariant();
            var filePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Images",
                $"{Guid.NewGuid()}{exteenstion}");

            using var sream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(sream);

            return TypedResults.Ok(
                new FileUploadResult($"/api/static-files/{Path.GetFileName(filePath)}")
            );
        }
        [HttpPut("{id}")]
        public async Task<Ok> Update(UserUpdate user, Guid id)
        {

            await _manager.UpdateAsync(user, id);
            return TypedResults.Ok();
        }
    }
}
public record FileUploadRequest(IFormFile File);

public record FileUploadResult(string FileUrl);
