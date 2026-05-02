using Microsoft.JSInterop;
using System.Text.Json;
using System.Threading.Tasks;
using EventEase.Models;

namespace EventEase.Services;

public class UserSessionService
{
    private readonly IJSRuntime _jsRuntime;

    public UserSessionService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task<User?> GetCurrentUserAsync()
    {
        var json = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "currentUser");
        if (string.IsNullOrEmpty(json)) return null;
        return JsonSerializer.Deserialize<User>(json);
    }

    public async Task SetCurrentUserAsync(User user)
    {
        var json = JsonSerializer.Serialize(user);
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "currentUser", json);
    }

    public async Task ClearCurrentUserAsync()
    {
        await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", "currentUser");
    }
}