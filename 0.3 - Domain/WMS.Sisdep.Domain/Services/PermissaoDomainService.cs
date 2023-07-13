using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
    public class PermissaoDomainService : IPermissaoDomainService
    {
        private readonly IPermissaoRepository _permissaoRepository;
        private readonly IMapper _mapper;
        public PermissaoDomainService(
            IPermissaoRepository permissaoRepository,
            IMapper mapper
        )
        {
            _permissaoRepository = permissaoRepository;
            _mapper = mapper;
        }

        public async Task Add(PermissaoBody body)
        {
            Permissao data = _mapper.Map<Permissao>(body);
            await _permissaoRepository.Add(data);
        }

        public async Task<IEnumerable<PermissaoModel>> GetAll()
        {
            return _mapper.Map<IEnumerable<PermissaoModel>>(await _permissaoRepository.GetAll());
        }

        public async Task<PermissaoModel> GetById(Guid id)
        {
            return _mapper.Map<PermissaoModel>(await _permissaoRepository.GetById(id));
        }

        public async Task Remove(Guid id)
        {
            Permissao perfil = await _permissaoRepository.GetById(id);
            await _permissaoRepository.Remove(perfil);
        }

        public async Task Update(Guid id, PermissaoBody body)
        {
            Permissao data = await _permissaoRepository.GetById(id);
            if (data == null)
                throw new CustomException("Not Found", (int)HttpStatusCode.NotFound, "Perfil não encontrado");

            data.TelaReferencia = body.TelaReferencia;
            data.PermiteEditar = body.PermiteEditar;
            data.PermiteInativar = body.PermiteInativar;
            data.PermiteAdicionar = body.PermiteAdicionar;
            data.PermiteVisualizar = body.PermiteVisualizar;

            await _permissaoRepository.Update(data);
        }
        public async Task<PaginatedBaseModel<PermissaoModel>> GetAllWithPaginated(PermissaoQuery query)
        {
            return _mapper.Map<PaginatedBaseModel<PermissaoModel>>(await _permissaoRepository.GetAllWithPaginated(query));
        }
    }
}
