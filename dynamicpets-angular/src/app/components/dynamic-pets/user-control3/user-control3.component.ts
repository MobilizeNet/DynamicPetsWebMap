import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { FormComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "dynamic-pets-user-control3",
   styleUrls : ["./user-control3.component.css"],
   templateUrl : "./user-control3.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["DynamicPets.UserControl3"])
export class UserControl3Component extends FormComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}