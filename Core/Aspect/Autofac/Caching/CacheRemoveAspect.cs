using System;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptor;
using Core.Utilities.Tools;

namespace Core.Aspect.Autofac.Caching;

public class CacheRemoveAspect:MethodInterception
{
	public string _key;
	private readonly ICacheService _cacheService;
	public CacheRemoveAspect(string key)
	{
		_key = key;
		_cacheService = ServiceTool.GetService<ICacheService>();
	}

    protected override void OnSuccess(IInvocation invocation)
    {
		_cacheService.Remove(_key);
		Console.WriteLine("Cache Cleared");
    }
}

