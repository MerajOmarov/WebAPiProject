using Application.Repositoties;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CreateUser
{
    public sealed class CreateTeacherHandler : IRequestHandler<CreateTeacherRequest, CreateTeacherResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITeacherRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateTeacherRequest> _validator;
    

        public CreateTeacherHandler(IUnitOfWork unitOfWork, ITeacherRepository userRepository, IMapper mapper, IValidator<CreateTeacherRequest> validator)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _mapper = mapper;
            _validator = validator;
           
        }

        public async Task<CreateTeacherResponse> Handle(CreateTeacherRequest request, CancellationToken cancellationToken)
        {
            var result = await _validator.ValidateAsync(request);
            if (!result.IsValid)
            {
                throw new Exception("Validation error");
            }
            var user = _mapper.Map<Teacher>(request);
            _userRepository.Create(user);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<CreateTeacherResponse>(user);
        }
    }
}
