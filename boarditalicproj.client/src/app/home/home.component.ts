import { Component } from '@angular/core';
import { WCUBox } from '../../../Models/wcubox';
import { Observable, observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { AppComponent } from '../app.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  WCUBoxes: WCUBox[] = [];

  LoadWcu: Observable<void> = new Observable<void>(x => {
    this.http.get<WCUBox[]>(`${this.app.backend}/Header/GetWCU`).subscribe(x => 
      {
        this.WCUBoxes = x;
        alert(this.WCUBoxes.length);
      }
    );
   
  });

  constructor(private http: HttpClient, private app: AppComponent)
  {
    this.LoadWcu.subscribe();
  }
}
