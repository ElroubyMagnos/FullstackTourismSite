import { Component } from '@angular/core';
import { SliderImage } from '../../../Models/slider-image';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AppComponent } from '../app.component';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.css'
})
export class HeaderComponent {
  Stopped: boolean = false;
  SliderImages: SliderImage[] = [];

  CurrentSlider: SliderImage;

  SliderObs: Observable<void> = new Observable<void>((ob) => 
  {
    this.http.get<SliderImage[]>(`${this.app.backend}/Header/GetHeaderSlideImages/`)
    .subscribe(x => this.SliderImages = x);
  });

  constructor(private http: HttpClient, private app: AppComponent)
  {
    this.SliderObs.subscribe();

    var i = 0;
    var intervalpics = setInterval(() => {

      if (i == this.SliderImages.length)
      {
        i = 0;
      }
      this.CurrentSlider = this.SliderImages[i];

      for (let x = 0; x < this.SliderImages.length; x++) {
        this.SliderImages[x].color = '#FFF';
      }

      this.CurrentSlider.color = '#1679AB';
      i++;
      
    }, 4000);
  }

  Selectit(img: HTMLSpanElement)
  {
    for (let i = 1; i < 4; i++) {
      document.getElementById('img' + i)!.style.backgroundColor = '#FFF';
    }
    for (let i = 1; i < 4; i++) {
      document.getElementById('title' + i)!.style.display = 'none';
    }
    var Target = document.querySelector('.backimage') as HTMLElement;
    img.style.backgroundColor = '#1679AB';
    
    Target.style.backgroundImage = `url('/assets/${img.id[3]}.jpg')`;
    document.getElementById('title' + img.id[3])!.style.display = 'block';
    document.getElementById('img' + img.id[3])!.style.backgroundColor = '#1679AB';
    Target.style.opacity = '1';
  }

  stopit()
  {
    this.Stopped = true;
  }
}
