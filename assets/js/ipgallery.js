
var lastCampaignTimeStamp = '';
var count = 16;
var campaignsurl = "https://api.wowsomeapp.com/v3.0/feedMetaData?count=16"
$(document).ready(function () {
    httpGet(campaignsurl);
});

function httpGet(url) {
    console.log('get campaigns', lastCampaignTimeStamp)
    if (lastCampaignTimeStamp) {
        url = url + "&timestamp=" + lastCampaignTimeStamp
    }
        fetch(url, {
            // mode: 'no-cors',
            headers: new Headers({ 'Content-Type': 'text/plain', 'x-license-key': 'iOd8XwQgXx8dXKiXbLhNOopdzUZTpNxX' })
        }).then( (res) => res.json())
        .then (data => {
          //  console.log(data)
            var campaigns = data.data;
            
            lastCampaignTimeStamp = campaigns[campaigns.length - 1].updatedAt;
            campaigns.forEach(function (campaign, index) {
                // console.log(index, campaign);
        
                $("#ipgalleryList").append($('<div class="camp-list-block" onclick="quickView(\'' +campaign._id + '\')" data-aos="fade-up"><div class="camp-list-block-in" id=campList'+index+'><div class="campaigns-brand"><div class="campaigns-brand-icon"><img alt="Profile image" src="' + campaign.createdBy.profileImage + '"></div><div class="campaigns-name"><span class="brand-name">' + campaign.createdBy.name.first + ' ' + campaign.createdBy.name.last + '</span><span class="desc">' + campaign.title + '</span></div></div><div class="campaign-img"><img alt="" src="' + campaign.trackableContent.url + '" alt="" /></div><div target="_blank" class="camp-hover"><span>Quick View</span></div></div></div>'));
            });
        })  
        .catch((err) => {
            console.log('Fetch Error :', err);
        });
    
        
}


 function quickView(cId){
console.log('gu',cId);
var reqData = { feedID: cId}
fetch('https://api.wowsomeapp.com/v3.0/findQuickView', {
    method:"POST",
    // mode: 'no-cors',
    headers: new Headers({ 'Content-Type': 'text/plain', 'x-license-key': 'iOd8XwQgXx8dXKiXbLhNOopdzUZTpNxX' }),
    body : JSON.stringify(reqData)
 
}).then( (res) => res.json())
.then (data => {
  // console.log(data);
   if (data.data.url) {
      window.open('https://quickview.wowso.me/'+ data.data.code, '_blank');
   } else if (data.data){
    window.open('https://quickview.wowso.me/'+ data.data.code, '_blank');
   }
})  
.catch((err) => {
    console.log('Fetch Error :', err);
});
}




