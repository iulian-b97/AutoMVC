import { Component } from "@angular/core";
import { FormBuilder } from "@angular/forms";
import { AnnouncementService } from "src/app/_announcement-management/announcement.service";
import { Announcement } from "../../announcement";
import { Truck } from "../truck";

@Component({
    selector: 'add-truck',
    templateUrl: './add-truck-announcement.component.html',
    styleUrls: ['./add-truck-announcement.component.css']
})
export class AddTruckAnnouncementComponent {
    constructor(private announcementService: AnnouncementService, private fb: FormBuilder) { }

    announcementForm = this.fb.group({
        announcement: this.fb.group(new Announcement()),
        truck: this.fb.group(new Truck())    
    });

    createAnnouncement() {
        this.announcementService.createTruckAnnouncement(this.announcementForm)
            .subscribe(() => {
                console.log(this.announcementForm.value)
                this.announcementForm.reset()
            })
    }
}