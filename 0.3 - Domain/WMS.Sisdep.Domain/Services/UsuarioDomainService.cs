using AutoMapper;
using System.Net;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Models;
using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Domain.Interfaces;
using WMS.Sisdep.Infra.Data.Entities;
using WMS.Sisdep.Infra.Middleware;
using WMS.Sisdep.Infra.OldData.Interfaces;
using WMS.Sisdep.Infra.OldData.Models;
using WMS.Sisdep.Infra.Repository.Interfaces;
using WMS.Sisdep.Infra.Repository.Repositories;

namespace WMS.Sisdep.Domain.Services
{
    public class UsuarioDomainService : IUsuarioDomainService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUsuarioOldRepository _usuarioOldRepository;
        private readonly IMapper _mapper;
        public UsuarioDomainService(
            IUsuarioRepository usuarioRepository,
            IUsuarioOldRepository usuarioOldRepository,
            IMapper mapper
        )
        {
            _usuarioRepository = usuarioRepository;
            _usuarioOldRepository = usuarioOldRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UsuarioOldModel>> GetAllOld()
        {
            return _mapper.Map<IEnumerable<UsuarioOldModel>>(await _usuarioOldRepository.GetAll());
        }
        public async Task<PaginatedBaseModel<UsuarioModel>> GetAllWithPaginated(UsuarioQuery query)
        {
            return _mapper.Map<PaginatedBaseModel<UsuarioModel>>(await _usuarioRepository.GetAllWithPaginated(query));
        }

        public async Task Add(UsuarioBody body)
        {
            Usuario data = _mapper.Map<Usuario>(body);
            await _usuarioRepository.Add(data);

            UsuarioEmpresa usuarioEmpresa = new UsuarioEmpresa();
            usuarioEmpresa.UsuarioId = data.Id;
            usuarioEmpresa.EmpresaId = body.EmpresaId;
            await _usuarioRepository.AddUsuarioEmpresa(usuarioEmpresa);
           
        }

        public async Task<IEnumerable<UsuarioModel>> GetAll()
        {
            return _mapper.Map<IEnumerable<UsuarioModel>>(await _usuarioRepository.GetAll());
        }

        public async Task<UsuarioModel> GetById(Guid id)
        {
            return _mapper.Map<UsuarioModel>(await _usuarioRepository.GetById(id));
        }

        public async Task Update(Guid id, UsuarioBody body)
        {
            Usuario data = await _usuarioRepository.GetById(id);
            if (data == null)
                throw new CustomException("Not Found", (int)HttpStatusCode.NotFound, "Usuario não encontrado");

            data.Nome = body.Nome;
            await _usuarioRepository.Update(data);
        }

        public async Task Remove(Guid id)
        {
            Usuario perfil = await _usuarioRepository.GetById(id);
            await _usuarioRepository.Remove(perfil);
        }

    }
}
