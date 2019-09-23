import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{HttpClientModule} from '@angular/common/http';

import { AppComponent } from './app.component';
import { CategoriaComponent } from './categoria/categoria.component';
import { HttpClient } from 'selenium-webdriver/http';

@NgModule({
   declarations: [
      AppComponent,
      CategoriaComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
