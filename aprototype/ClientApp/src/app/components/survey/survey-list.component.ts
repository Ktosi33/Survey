import { Component, Inject, Input, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { HttpClient } from "@angular/common/http";

@Component({
  selector: "survey-list",
  templateUrl: './survey-list.component.html',
  styleUrls: ['./survey-list.component.css']
})

export class SurveyListComponent implements OnInit {
  @Input() class: string;
  title: string;
  selectedSurvey: Survey;
  surveys: Survey[];

  constructor(private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    private router: Router) {
  }


  ngOnInit() {
    var url = this.baseUrl + "api/survey/";

    switch (this.class) {
      case "latest":
      default:
        this.title = "Najnowsze ankiety";
        url += "Latest/";
        break;
      case "byTitle":
        this.title = "Ankiety alfabetycznie";
        url += "ByTitle/";
        break;
      case "random":
        this.title = "Losowe ankiety";
        url += "Random/";
        break;
    }
  
    this.http.get<Survey[]>(url).subscribe(result => {
      this.surveys = result;

    }, error => console.error(error));

  }
  onSelect(survey: Survey) {
    this.selectedSurvey = survey;
    console.log("Wybrano ankiete o ID" + this.selectedSurvey.Id);
    this.router.navigate(["survey", this.selectedSurvey.Id]);

  }
}
