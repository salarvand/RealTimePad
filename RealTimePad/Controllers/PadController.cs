using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealTimePad.Models.PadViewModels;
using ServiceStack;

namespace RealTimePad.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/pad")]
    public class PadController : Controller
    {
        private AppSettings AppSettings { get; set; }

        public PadController(Microsoft.Extensions.Options.IOptions<AppSettings> settings)
        {
            AppSettings = settings.Value;
        }

        [HttpPost("createAuthor")]
        public JsonResult CreateAuthorIfNotExistsFor(CreateAuthorRequest model)
        {
            var request = $"{AppSettings.Api}createAuthorIfNotExistsFor".PostJsonToUrl(
              new
              {
                  apikey =AppSettings.ApiKey,
                  name = model.Name,
                  authorMapper = model.AuthorMapper
              });

            var responce = JsonConvert.DeserializeObject<CreateAuthorResponce>(request);

            return Json(responce);
        }

        [HttpPost("createGroup")]
        public JsonResult CreateGroupIfNotExistsFor(CreateGroupRequest model)
        {
            var request = $"{AppSettings.Api}createGroupIfNotExistsFor".PostJsonToUrl(
                new
                {
                    apikey = AppSettings.ApiKey,
                    groupMapper = model.GroupMapper
                });

            var responce = JsonConvert.DeserializeObject<CreateGroupResponce>(request);

            return Json(responce);
        }

        [HttpPost("createGroupPad")]
        public JsonResult CreateGroupPad(CreateGroupPadRequest model)
        {
            var request = $"{AppSettings.Api}createGroupPad".PostJsonToUrl(
                new
                {
                    apikey = AppSettings.ApiKey,
                    groupID = model.GroupId,
                    padName = model.PadName,
                    text = model.Text
                });

            var responce = JsonConvert.DeserializeObject<CreateGroupPadResponce>(request);

            return Json(responce);
        }

        [HttpPost("createSession")]
        public JsonResult CreateSession(CreateSessionRequest model)
        {
            var request = $"{AppSettings.Api}createSession".PostJsonToUrl(
                new
                {
                    apikey = AppSettings.ApiKey,
                    groupID = model.GroupId,
                    authorID = model.AuthorId,
                    validUntil = model.ValidUntil
                });

            var responce = JsonConvert.DeserializeObject<CreateSessionResponce>(request);

            return Json(responce);
        }

        [HttpPost("deleteGroup")]
        public JsonResult DeleteGroup(DeleteGroupRequest model)
        {
            var request = $"{AppSettings.Api}deleteGroup".PostJsonToUrl(
                new
                {
                    apikey = AppSettings.ApiKey,
                    groupID = model.GroupId
                });

            var responce = JsonConvert.DeserializeObject<DeleteGroupResponce>(request);

            return Json(responce);
        }

        [HttpPost("listPads")]
        public JsonResult ListPads(ListPadsRequest model)
        {
            var request = $"{AppSettings.Api}listPads".PostJsonToUrl(
                new
                {
                    apikey = AppSettings.ApiKey,
                    groupID = model.GroupId
                });

            var responce = JsonConvert.DeserializeObject<ListPadsResponce>(request);

            return Json(responce);
        }

        [HttpPost("listAllGroups")]
        public JsonResult ListAllGroups(ListAllGroupsRequest model)
        {
            var request = $"{AppSettings.Api}listAllGroups".PostJsonToUrl(
                new
                {
                    apikey = AppSettings.ApiKey
                });

            var responce = JsonConvert.DeserializeObject<ListAllGroupsResponce>(request);

            return Json(responce);
        }

        [HttpPost("listPadsOfAuthor")]
        public JsonResult ListPadsOfAuthor(ListPadsOfAuthorRequest model)
        {
            var request = $"{AppSettings.Api}listPadsOfAuthor".PostJsonToUrl(
                new
                {
                    apikey = AppSettings.ApiKey,
                    authorID = model.AuthorId
                });

            var responce = JsonConvert.DeserializeObject<ListPadsOfAuthorResponce>(request);

            return Json(responce);
        }

        [HttpPost("deleteSession")]
        public JsonResult DeleteSession(DeleteSessionRequest model)
        {
            var request = $"{AppSettings.Api}deleteSession".PostJsonToUrl(
                new
                {
                    apikey = AppSettings.ApiKey,
                    sessionID = model.SessionId
                });

            var responce = JsonConvert.DeserializeObject<DeleteSessionResponce>(request);

            return Json(responce);
        }

        [HttpPost("getSessionInfo")]
        public JsonResult GetSessionInfo(GetSessionInfoRequest model)
        {
            var request = $"{AppSettings.Api}getSessionInfo".PostJsonToUrl(
                new
                {
                    apikey = AppSettings.ApiKey,
                    sessionID = model.SessionId
                });

            var responce = JsonConvert.DeserializeObject<GetSessionInfoResponce>(request);

            return Json(responce);
        }

        [HttpPost("getText")]
        public JsonResult GetText(GetTextRequest model)
        {
            string request;

            if (!string.IsNullOrEmpty(model.Rev))
            {
                request = $"{AppSettings.Api}getText".PostJsonToUrl(
                    new
                    {
                        apikey = AppSettings.ApiKey,
                        padID = model.PadId,
                        rev = model.Rev
                    });
            }
            else
            {
                request = $"{AppSettings.Api}getText".PostJsonToUrl(
                    new
                    {
                        apikey = AppSettings.ApiKey,
                        padID = model.PadId
                    });
            }
            

            var responce = JsonConvert.DeserializeObject<GetTextResponce>(request);

            return Json(responce);
        }

        [HttpPost("setText")]
        public JsonResult SetText(SetTextRequest model)
        {
            var request = $"{AppSettings.Api}setText".PostJsonToUrl(
                new
                {
                    apikey = AppSettings.ApiKey,
                    padID = model.PadId,
                    text = model.Text
                });

            var responce = JsonConvert.DeserializeObject<SetTextResponce>(request);

            return Json(responce);
        }

        [HttpPost("getRevisionChangeset")]
        public JsonResult GetRevisionChangeset(GetRevisionChangesetRequest model)
        {
            var request = $"{AppSettings.Api}getRevisionChangeset".PostJsonToUrl(
                new
                {
                    apikey = AppSettings.ApiKey,
                    padID = model.PadId,
                    rev = model.Rev
                });

            var responce = JsonConvert.DeserializeObject<GetRevisionChangesetResponce>(request);

            return Json(responce);
        }
    }
}