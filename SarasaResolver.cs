using AutoMapper;
using AutoMapperDI.Controllers;

namespace AutoMapperDI
{
	public class SarasaResolver : IValueResolver<Sarasa, SarasaVM, string>
	{
		private readonly ISarasaService _sarasaService;
		public SarasaResolver(ISarasaService sarasaService)
		{
			_sarasaService = sarasaService;
		}
		public string Resolve(Sarasa source, SarasaVM destination, string member, ResolutionContext context)
		{
			return _sarasaService.GiveMeSarasa();
		}

        public string Resolve(Sarasa source, SarasaVM destination, string sourceMember, string destMember, ResolutionContext context)
        {
			return _sarasaService.GiveMeSarasa();
		}
    }
}