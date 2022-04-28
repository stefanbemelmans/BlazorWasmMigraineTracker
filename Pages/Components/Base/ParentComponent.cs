namespace BlazorWasmMigraineTracker.Pages.Components
{
  using Microsoft.AspNetCore.Components;

  public class ParentComponent : DisplayComponent, IParentComponent
  {
    [Parameter] public RenderFragment ChildContent { get; set; }
  }
}
