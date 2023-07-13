using AutoMapper;
using System.Net;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Models;
using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Domain.Interfaces;
using WMS.Sisdep.Infra.Data.Entities;
using WMS.Sisdep.Infra.Middleware;
using WMS.Sisdep.Infra.Repository.Interfaces;
using WMS.Sisdep.Infra.Repository.Repositories;

namespace WMS.Sisdep.Domain.Services
{
    public class PerfilDomainService : IPerfilDomainService
    {
        private readonly IPerfilRepository _perfilRepository;
        private readonly IMapper _mapper;
        public PerfilDomainService(
            IPerfilRepository perfilRepository,
            IMapper mapper
        )
        {
            _perfilRepository = perfilRepository;
            _mapper = mapper;
        }

        public async Task Add(PerfilBody body)
        {
            Perfil data = _mapper.Map<Perfil>(body);
            await _perfilRepository.Add(data);
        }

        public async Task<PaginatedBaseModel<PerfilModel>> GetAllWithPaginated(PerfilQuery query)
        {
            return _mapper.Map<PaginatedBaseModel<PerfilModel>>(await _perfilRepository.GetAllWithPaginated(query));
        }

        public async Task<PerfilModel> GetById(Guid id)
        {
            return _mapper.Map<PerfilModel>(await _perfilRepository.GetById(id));
        }

        public async Task Remove(Guid id)
        {
            Perfil perfil = await _perfilRepository.GetById(id);
            await _perfilRepository.Remove(perfil);
        }

        public async Task Update(Guid id, PerfilBody body)
        {
            Perfil data = await _perfilRepository.GetById(id);
            if (data == null)
                throw new CustomException("Not Found", (int)HttpStatusCode.NotFound, "Perfil não encontrado");

            data.Nome = body.Nome;
            await _perfilRepository.Update(data);
        }
    }
}
