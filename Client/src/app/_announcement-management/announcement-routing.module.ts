import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '../auth/auth.guard';

import { HomeComponent } from './home/home.component';
import { AddAnnouncementComponent } from './add-announcement/add-announcement.component';
import { SearchCarComponent } from './home/search-car/search-car.component';
import { SearchMotorcycleComponent } from './home/search-motorcycle/search-motorcycle.component';
import { SearchTrailerComponent } from './home/search-trailer/search-trailer.component';
import { SearchTruckComponent } from './home/search-truck/search-truck.component';
import { SearchVanComponent } from './home/search-van/search-van.component';
import { ViewCarAnnouncementComponent } from './announcement/car-announcement/view-car-announcement/view-car-announcement.component';
import { ViewMotorcycleAnnouncementComponent } from './announcement/motorcycle-announcement/view-motorcycle-announcement/view-motorcycle-announcement.component';
import { ViewTrailerAnnouncementComponent } from './announcement/trailer-announcement/view-trailer-announcement/view-trailer-announcement.component';
import { ViewTruckAnnouncementComponent } from './announcement/truck-announcement/view-truck-announcement/view-truck-announcement.component';
import { ViewVanAnnouncementComponent } from './announcement/van-announcement/view-van-announcement/view-van-announcement.component';
import { FilteredCarAnnouncementsComponent } from './filtered-announcements/filtered-car-announcements/filtered-car-announcements.component';
import { FilteredMotorcycleAnnouncementsComponent } from './filtered-announcements/filtered-motorcycle-announcements/filtered-motorcycle-announcements.component';
import { FilteredTrailerAnnouncementsComponent } from './filtered-announcements/filtered-trailer-announcements/filtered-trailer-announcements.component';
import { FilteredTruckAnnouncementsComponent } from './filtered-announcements/filtered-truck-announcements/filtered-truck-announcements.component';
import { FilteredVanAnnouncementsComponent } from './filtered-announcements/filtered-van-announcements/filtered-van-announcements.component';


const routes: Routes = [
    { 
        path: 'home', component: HomeComponent, 
        children: [
          { path: 'search-car', component: SearchCarComponent },
          { path: 'search-motorcycle', component: SearchMotorcycleComponent },
          { path: 'search-truck', component: SearchTruckComponent },
          { path: 'search-van', component: SearchVanComponent },
          { path: 'search-trailer', component: SearchTrailerComponent }
        ] 
      },
      { path: 'car-announcements', component: FilteredCarAnnouncementsComponent },
      { path: 'motorcycle-announcements', component: FilteredMotorcycleAnnouncementsComponent },
      { path: 'truck-announcements', component: FilteredTruckAnnouncementsComponent },
      { path: 'van-announcements', component: FilteredVanAnnouncementsComponent },
      { path: 'trailer-announcements', component: FilteredTrailerAnnouncementsComponent },
      { path: 'view-car-announcement', component: ViewCarAnnouncementComponent },
      { path: 'view-motorcycle-announcement', component: ViewMotorcycleAnnouncementComponent },
      { path: 'view-truck-announcement', component: ViewTruckAnnouncementComponent },
      { path: 'view-van-announcement', component: ViewVanAnnouncementComponent },
      { path: 'view-trailer-announcement', component: ViewTrailerAnnouncementComponent },
      {
        path: 'add-announcement', component: AddAnnouncementComponent, canActivate:[AuthGuard]
      }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
  })
  export class AnnouncementRoutingModule { }
