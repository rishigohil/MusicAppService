import { Component } from '@angular/core';
@Component({
    selector: 'my-app',
    template: `    
    <h2>{{myskills}}</h2>
    <p>Skill:</p>
    <ul>
      <li *ngFor="let skl of skills">
        {{ skl }}
      </li>
    </ul>
  `
})
export class AppComponent {
    title = 'Music App';
    skills = ['Music', 'Angular 2', 'Music Backend', 'This texts are coming from Angular 2 implementation'];
    myskills = this.skills[3];
}