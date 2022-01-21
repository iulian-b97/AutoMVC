import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CarAnnouncementComponent } from './announcement/car-announcement/car-announcement.component';
import { MotorcycleAnnouncementComponent } from './announcement/motorcycle-announcement/motorcycle-announcement.component';
import { TruckAnnouncementComponent } from './announcement/truck-announcement/truck-announcement.component';
import { VanAnnouncementComponent } from './announcement/van-announcement/van-announcement.component';
import { TrailerAnnouncementComponent } from './announcement/trailer-announcement/trailer-announcement.component';
import { FilteredCarAnnouncementsComponent } from './filtered-announcements/filtered-car-announcements/filtered-car-announcements.component';
import { FilteredMotorcycleAnnouncementsComponent } from './filtered-announcements/filtered-motorcycle-announcements/filtered-motorcycle-announcements.component';
import { FilteredTruckAnnouncementsComponent } from './filtered-announcements/filtered-truck-announcements/filtered-truck-announcements.component';
import { FilteredVanAnnouncementsComponent } from './filtered-announcements/filtered-van-announcements/filtered-van-announcements.component';
import { FilteredTrailerAnnouncementsComponent } from './filtered-announcements/filtered-trailer-announcements/filtered-trailer-announcements.component';
import { ViewCarAnnouncementComponent } from './announcement/car-announcement/view-car-announcement/view-car-announcement.component';
import { ViewMotorcycleAnnouncementComponent } from './announcement/motorcycle-announcement/view-motorcycle-announcement/view-motorcycle-announcement.component';
import { ViewTruckAnnouncementComponent } from './announcement/truck-announcement/view-truck-announcement/view-truck-announcement.component';
import { ViewVanAnnouncementComponent } from './announcement/van-announcement/view-van-announcement/view-van-announcement.component';
import { ViewTrailerAnnouncementComponent } from './announcement/trailer-announcement/view-trailer-announcement/view-trailer-announcement.component';
import { AddAnnouncementComponent } from './add-announcement/add-announcement.component';
import { AddCarAnnouncementComponent } from './announcement/car-announcement/add-car-announcement/add-car-announcement.component';
import { AddMotorcycleAnnouncementComponent } from './announcement/motorcycle-announcement/add-motorcycle-announcement/add-motorcycle-announcement.component';
import { AddTruckAnnouncementComponent } from './announcement/truck-announcement/add-truck-announcement/add-truck-announcement.component';
import { AddVanAnnouncementComponent } from './announcement/van-announcement/add-van-announcement/add-van-announcement.component';
import { AddTrailerAnnouncementComponent } from './announcement/trailer-announcement/add-trailer-announcement/add-trailer-announcement.component';
import { AppRoutingModule } from '../app-routing.module';
import { SearchCarComponent } from './home/search-car/search-car.component';
import { SearchMotorcycleComponent } from './home/search-motorcycle/search-motorcycle.component';
import { SearchTruckComponent } from './home/search-truck/search-truck.component';
import { SearchVanComponent } from './home/search-van/search-van.component';
import { SearchTrailerComponent } from './home/search-trailer/search-trailer.component';
import { HomeComponent } from './home/home.component';


@NgModule({
  declarations: [
    CarAnnouncementComponent,
    MotorcycleAnnouncementComponent,
    TruckAnnouncementComponent,
    VanAnnouncementComponent,
    TrailerAnnouncementComponent,
    FilteredCarAnnouncementsComponent,
    FilteredMotorcycleAnnouncementsComponent,
    FilteredTruckAnnouncementsComponent,
    FilteredVanAnnouncementsComponent,
    FilteredTrailerAnnouncementsComponent,
    ViewCarAnnouncementComponent,
    ViewMotorcycleAnnouncementComponent,
    ViewTruckAnnouncementComponent,
    ViewVanAnnouncementComponent,
    ViewTrailerAnnouncementComponent,
    AddAnnouncementComponent,
    AddCarAnnouncementComponent,
    AddMotorcycleAnnouncementComponent,
    AddTruckAnnouncementComponent,
    AddVanAnnouncementComponent,
    AddTrailerAnnouncementComponent,
    SearchCarComponent,
    SearchMotorcycleComponent,
    SearchTruckComponent,
    SearchVanComponent,
    SearchTrailerComponent,
    HomeComponent
  ],
  imports: [
    CommonModule,
    AppRoutingModule
  ],
  exports: [
    CarAnnouncementComponent,
    MotorcycleAnnouncementComponent,
    TruckAnnouncementComponent,
    VanAnnouncementComponent,
    TrailerAnnouncementComponent,
  ]
})
export class AnnouncementModule { }