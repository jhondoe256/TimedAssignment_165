using Microsoft.AspNetCore.Mvc;
using TimedAssignment.Services.ReplyServices;

namespace TimedAssignment_165.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Repliescontroller : ControllerBase
    {
        private readonly IReplyService _replyServices;

        public Repliescontroller(IReplyService replyServices)
        {
            _replyServices = replyServices;
        }
    }
}