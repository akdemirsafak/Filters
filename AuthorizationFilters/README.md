# Authorization Filters

İlk çalışan filter'dır.
Bu filtre kullanıcının yaptığı bir istek için _ Yetkisinin olup olmadığını belirlemek için kullanılır _ Eğer yetkisi yoksa Short-circuit(Kısa devre) ile işlem kesilir ve response döner.

Bir token ile çalışır.

Custom yazılabileceği gibi AspNetCore da Authorization filter içerir:

- using Microsoft.AspNetCore.Authorization;
- [Authorize] şeklinde Yazılabilir.

Custom yazılacaksa IAuthorizationFilter 'dan implemente edilir.
