import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { WelcomeComponent } from "./components/welcome.component";
import { NewIssueComponent } from "./components/new-issue.component";
import { NavBarComponent } from "./components/nav-bar.component";

@Component({
    selector: 'app-root',
    standalone: true,
    template: `
    <app-nav-bar />
    <main class="container mx-auto">

    </main>
  `,
    styles: [],
    imports: [RouterOutlet, NavBarComponent]
})
export class AppComponent {}
