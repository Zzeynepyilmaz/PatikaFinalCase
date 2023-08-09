using ApartmentManagementSystem.ApartmentManagementSystem.Base.ApiResponse;
using ApartmentManagementSystem.ApartmentManagementSystem.Data.Uow;
using ApartmentManagementSystem.Entities;
using ApartmentManagementSystem.MsDbContext;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ManagementSystemDbContext context;
        private readonly IMapper mapper;

        public MessagesController(ManagementSystemDbContext context, IMapper mapper, IUnitOfWork unitOfWork)
        {
            context = context;
            mapper = mapper;
            unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ApiResponse<List<Message>> GetAll()
        {
            var messageList = unitOfWork.MessageRepository.GetAll();
            var mapped = mapper.Map<List<Message>, List<Message>>(messageList);
            return new ApiResponse<List<Message>>(mapped);
        }

        [HttpGet("{id}")]
        public ApiResponse<Message> GetById(int id)
        {
            var message = unitOfWork.MessageRepository.GetById(id);
            var mapped = mapper.Map<Message>(message);
            return new ApiResponse<Message>(mapped);
        }

        [HttpPost]
        public ApiResponse AddMessage([FromBody] Message message)
        {
            unitOfWork.MessageRepository.Insert(message);
            unitOfWork.MessageRepository.Save();
            return new ApiResponse();
        }

        [HttpPut("{id}")]
        public ApiResponse UpdateMessage(int id, [FromBody] Message message)
        {

            unitOfWork.MessageRepository.Insert(message);
            message.MessageId = id;

            unitOfWork.MessageRepository.Update(message);
            unitOfWork.MessageRepository.Save();
            return new ApiResponse();
        }


        [HttpDelete("{id}")]
        public ApiResponse DeleteMessage(int id)
        {
            unitOfWork.MessageRepository.DeleteById(id);
            unitOfWork.MessageRepository.Save();
            return new ApiResponse();
        }
    }
}
