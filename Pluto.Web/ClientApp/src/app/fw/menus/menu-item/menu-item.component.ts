import { Component,ElementRef, HostBinding,HostListener,
   Input, OnInit,Renderer } from '@angular/core';

import {NavigationEnd,Router} from '@angular/router';

import {IMenuItem,MenuService} from '../../services/menu.service';

@Component({
  selector: 'fw-menu-item',
  templateUrl: './menu-item.component.html',
  styleUrls: ['./menu-item.component.css']
})
export class MenuItemComponent implements OnInit {


// Info: the below had to commented bcos of issue with CLI which required i/f in separate file
//@Input() item:MenuItem; // see angular-cli issue #2034
@Input() item=<IMenuItem>null;
@HostBinding('class.parent-is-popup')
  @Input() parentIsPopup = true;
  isActiveRoute = false;

  mouseInItem = false;
  mouseInPopup = false;
  popupLeft = 0;
  popupTop = 34;


  constructor(private router: Router,
  public menuService:MenuService,
  private el:ElementRef,
  private renderer:Renderer) { }

  checkActiveRoute(route: string) {
    this.isActiveRoute = (route == '/' + this.item.route);
  }

  ngOnInit() {
    this.checkActiveRoute(this.router.url);

    this.router.events
        .subscribe((event) => {
            if (event instanceof NavigationEnd) {
                this.checkActiveRoute(event.url);
                console.log(event.url + ' ' + this.item.route + ' ' + this.isActiveRoute);
            }
        });
  }

  @HostListener('click', ['$event'])
  onClick(event): void {

    event.stopPropagation();

    if (this.item.submenu) {
      if (this.menuService.isVertical) {
        this.mouseInPopup = !this.mouseInPopup;
      }
    }
    else if (this.item.route) {
      // force horizontal menus to close by sending a mouseleave event
      let newEvent = new MouseEvent('mouseleave', { bubbles: true });
      this.renderer.invokeElementMethod(
        this.el.nativeElement, 'dispatchEvent', [newEvent]);

      this.router.navigate(['/' + this.item.route]);

    }
  }

  onPopupMouseEnter(event): void {
    if (!this.menuService.isVertical) {
      this.mouseInPopup = true;
    }
  }

  onPopupMouseLeave(event): void {
    if (!this.menuService.isVertical) {
      this.mouseInPopup = false;
    }
  }

  @HostListener('mouseleave', ['$event'])
  onMouseLeave(event): void {
    if (!this.menuService.isVertical) {
      this.mouseInItem = false;
    }
  }

  @HostListener('mouseenter')
  onMouseEnter(): void {
    if (!this.menuService.isVertical) {
      if (this.item.submenu) {
        this.mouseInItem = true;
        if (this.parentIsPopup) {
          this.popupLeft = 160;
          this.popupTop = 0;
        }
      }
    }
  }

}
